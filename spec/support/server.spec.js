var request = require('request');

describe('get messages', () => {
    it('should return 200 ok', (done) => {
        request.get('http://localhost:3000', (err, res) => {
            expect(res.statusCode).toEqual(200)
            done()
        })

    })
/**
    it('should return more than 1 item', (done) => {
        request.get('http://localhost:3000/postings', (err, res) => {
            expect(JSON.parse(res.body).length).toBeGreaterThan(1)
            done()
        })
    })
    **/
})