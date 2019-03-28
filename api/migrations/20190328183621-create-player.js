'use strict';
module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.createTable('Players', {
      PlayerId: {
        type: Sequelize.INTEGER,
      },
      FirstCardImagePath: {
        type: Sequelize.STRING,
      },
      SecondCardImagePath: {
        type: Sequelize.STRING,
      }
    });
  },
  down: (queryInterface, Sequelize) => {
    return queryInterface.dropTable('Players');
  }
};