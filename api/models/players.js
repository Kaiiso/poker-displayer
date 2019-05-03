'use strict';
module.exports = (sequelize, DataTypes) => {
  const Players = sequelize.define('Players', {
    PlayerId: DataTypes.INTEGER,
    Nickname: DataTypes.STRING,
    FirstCard: DataTypes.STRING,
    SecondCard: DataTypes.STRING
  }, {});
  Players.associate = function(models) {
    // associations can be defined here
  };
  return Players;
};