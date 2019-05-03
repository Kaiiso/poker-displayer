// Imports
const express = require('express');
const playercontrollers = require('./routes/player-controllers');

// Router
exports.router = (() => {
    let apirouter = express.Router();

    // Players routes
    apirouter.route('/player/update-info/').put(playercontrollers.updateinfo);
    apirouter.route('/player/get-info/').get(playercontrollers.getinfo);
    apirouter.route('/player/reset-info/').get(playercontrollers.resetinfo);

    return apirouter;
})();