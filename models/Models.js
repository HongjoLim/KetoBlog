const mongoose = require('mongoose');

exports.Posting = mongoose.model('Posting', {
    user_id: String,
    title: String,
    content: String,
    created: Date,
    updated: Date
});