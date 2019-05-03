'use strict';
module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.createTable('Players', {
      PlayerId: {
        type: Sequelize.INTEGER,
        allownull: true
      },
      FirstCardImagePath: {
        type: Sequelize.STRING,
        allownull: true
      },
      SecondCardImagePath: {
        type: Sequelize.STRING,
        allownull: true
      }
    });
  },
  down: (queryInterface, Sequelize) => {
    return queryInterface.dropTable('Players');
  }
};