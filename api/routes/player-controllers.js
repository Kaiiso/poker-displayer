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
			attributes: ['PlayerId', 'FirstCard', 'SecondCard'],
			where: {PlayerId: parseInt(player)}
		}).then((userFound) => {
			if (userFound) {
				if (cardNumber == 1) {

					userFound.update({
						FirstCard: cardValue
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
						SecondCard: cardValue
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
	updatenickname: (req, res) => {
		// Params
		let player = req.body.playerId;
		let nickname = req.body.nickname;

		if (player == null || player == '' || nickname == null || nickname == ''){
			return res.json({error : 'missing parameters'});
		}

		models.Player.findOne({
			attributes: ['PlayerId', 'Nickname'],
			where: {PlayerId: parseInt(player)}
		}).then((userFound) => {
			if (userFound) {
				userFound.update({
					Nickname: nickname
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
				return res.json({error : 'player not found in database'});
			}
		}).catch((err) => {
			return res.json({error : 'unable to find player'});
		});
	},
	getinfo: (req, res) => {
		models.Player.findAll({attributes : ['PlayerId', 'Nickname', 'FirstCard', 'SecondCard']}).then((players) => {
			if (players) {
				return res.json({players : players});
			} else {
				return res.json({error : 'can\'t find players'});
			}
		})
	},
	resetinfo: (req, res) => {
		models.Player.findAll().then((players) => {
			if (players) {
				players.forEach(item => {
					item.update({
						Nickname: 'null',
						FirstCard: 'null',
						SecondCard: 'null'
					}).catch((err) => {
						return res.json({error : 'cannot update player'});
					});
				});	
				return res.json({success : 'reset succeed'});	
			} else {
				return res.json({error : 'can\'t find players'});
			}
		});
	}
};