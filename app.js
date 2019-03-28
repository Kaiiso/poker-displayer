// Imports
require('dotenv').config();
const express = require('express');
const app = express();
const bodyParser = require('body-parser');
const apirouter = require('./api/api-router').router;
const path = require('path');
const cors = require('cors');

const port = process.env.PORT || 8080;

// Body parser configuration
app.use(bodyParser.urlencoded({extended: true}));
app.use(bodyParser.json());

app.use(express.static(`${__dirname}/public`));

app.get('/', (req, res) => {
    res.sendFile('index.html')
});

app.use(cors());

app.use('/api/', apirouter);

app.use((req, res) => {
    res.setHeader('Access-Control-Allow-Origin', '*');
    res.setHeader('Access-Control-Allow-Methods', 'GET, POST, PUT');
    res.setHeader('Access-Control-Allow-Headers', 'Content-Type');
    res.setHeader('Access-Control-Allow-Credentials', true);
});

// Start server
app.listen(port, () => {
    console.log(`Server listening on port ${port}`);
});