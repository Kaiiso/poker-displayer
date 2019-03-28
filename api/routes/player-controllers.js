// Imports
const models = require('../models');

// Routes
module.exports = {
	updateinfo: (req, res) => {
		// Params
		let player = req.body.player;
		let card = req.body.card;
		let cardNumber = req.body.cardNumber;

		// Verifying if user is already registered
		models.Teacher.findOne({
			attributes: ['Email'],
			where: {Email: email}
		})
		.then(userFound => {
			if (!userFound) {
				bcrypt.hash(password, 10, (err, bcryptedPassword) => {
					let newUser = models.Teacher.create({
						UUID: UUID,
						Surname: surname,
						Name: name,
						Password: bcryptedPassword,
						Timezone: timezone,
						Email: email,
						DisplayName: displayName,
						AvatarPath: null
					})
					.then(newUser => {
						return res.status(201).json({UUID: newUser.UUID});
					})
					.catch(err => {
						return res.status(500).json({error: 'cannot add user'});
					});
				});
			} else {
				return res.status(409).json({error: 'email is already taken'});
			}
		})
		.catch(err => {
			return res.status(500).json({error: 'unable to verify user'});
		});
	},
	getinfo: (req, res) => {

	}
};