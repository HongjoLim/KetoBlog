const express = require('express');
const app = express();
const http = require('http').Server(app);
const bp = require('body-parser');
const socket = require('socket.io')(http);
const mongoose = require('mongoose');
const models = require('./models/Models');
require('dotenv').config();

const DB_URL = process.env.MONGOLAB_URI;

app.use(express.static(__dirname));
app.use(bp.json());
app.use(bp.urlencoded({extended: false}));

const postings = [];

app.get('/postings', (req, res) => {
    res.send(postings);
})

app.post('/postings', (req, res) => {
    let posting = models.Posting(req.body);

    posting.save(err => {
        if (err)
            sendStatus(500);
        else {
            socket.emit('post', req.body);
            res.sendStatus(200);
        }
    });
})

socket.on('connection', (so) => {
    console.log('user connected!');
});

mongoose.connect(DB_URL, (err) => {
    if (err) console.log(err);
});

const server = http.listen(3000);