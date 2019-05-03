// Imports
const models = require('../models');

// Routes
module.exports = {
	updateinfo: (req, res) => {
		// Params
		let player = req.body.playerId;
		let cardValue = req.body.cardValue;
		let cardNumber = req.body.cardNumber;

		if (player == null || player == '' || cardValue == null || cardValue == '' || cardNumber == null || cardNumber == ''){
			return res.json({error : 'missing parameters'});
		}

		models.Player.findOne({
			attributes: ['PlayerId', 'FirstCardImagePath', 'SecondCardImagePath'],
			where: {PlayerId: parseInt(player)}
		}).then((userFound) => {
			if (userFound) {

				if (cardNumber == 1) {

					userFound.update({
						FirstCardImagePath: cardValue
					}).then(() => {
						if (userFound) {
							return res.json(userFound);
						} else {
							return res.json({error : 'cannot update player cards'});
						}
					}).catch((err) => {
						return res.json({error : 'cannot update player'});
					});

				} else if (cardNumber == 2) {

					userFound.update({
						SecondCardImagePath: cardValue
					}).then(() => {
						if (userFound) {
							return res.json(userFound);
						} else {
							return res.json({error : 'cannot update player cards'});
						}
					}).catch((err) => {
						return res.json({error : 'cannot update player'});
					});

				} else {
					return res.json({error : 'card number is not correct (1 or 2)'});
				}

			} else {
				return res.json({error : 'player not found in database'});
			}
		}).catch((err) => {
			return res.json({error : 'unable to find player'});
		});
	},
	getinfo: (req, res) => {
		models.Player.findAll({attributes : ['PlayerId', 'FirstCardImagePath', 'SecondCardImagePath']}).then((players) => {
			if (players) {
				return res.json({'players' : players});
			} else {
				return res.json({error : 'can\'t find players'});
			}
		});
	},
	resetinfo: (req, res) => {
		models.Player.findAll().then((players) => {
			if (players) {
				players.truncate();
				return res.json({success: 'reset succeed'});
			} else {
				return res.json({error: 'can\'t find players'});
			}
		});
	}
};