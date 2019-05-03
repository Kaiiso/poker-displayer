'use strict';
module.exports = {
  up: (queryInterface, Sequelize) => {
    return queryInterface.createTable('Players', {
      PlayerId: {
        type: Sequelize.INTEGER,
        allownull: true
      },
      Nickname: {
        type: Sequelize.STRING,
        allownull: true
      },
      FirstCard: {
        type: Sequelize.STRING,
        allownull: true
      },
      SecondCard: {
        type: Sequelize.STRING,
        allownull: true
      }
    });
  },
  down: (queryInterface, Sequelize) => {
    return queryInterface.dropTable('Players');
  }
};