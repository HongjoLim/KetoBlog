const express = require('express');
const app = express();
const http = require('http').Server(app);
const bp = require('body-parser');
const socket = require('socket.io')(http);
const mongoose = require('mongoose');
const models = require('./models/Models');
require('dotenv').config();

mongoose.Promise = Promise;

const DB_URL = process.env.MONGOLAB_URI;

app.use(express.static(__dirname));
app.use(bp.json());
app.use(bp.urlencoded({extended: false}));

app.get('/postings', (req, res) => {
    models.Posting.find({})
    .then(postings => res.send(postings));
});

app.post('/postings', async (req, res) => {
    try {
        
        let posting = models.Posting(req.body);

        await posting.save();
    
        const empty = await models.Posting.findOne().or([{content:''}, {title: ''}]);
    
        if (empty) {
            return models.Posting.deleteOne({_id: empty.id});
        } else {
            socket.emit('post', req.body);
            res.sendStatus(200);
        }
    } catch (err) {
        res.sendStatus(500);
    }
});

socket.on('connection', (so) => {
    console.log('user connected!');
});

mongoose.connect(DB_URL, (err) => {
    if (err) console.log(err);
});

const server = http.listen(3000);