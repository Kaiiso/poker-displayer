'use strict';
module.exports = (sequelize, DataTypes) => {
  const Player = sequelize.define('Player', {
    PlayerId: {
      type: DataTypes.INTEGER,
      primaryKey: true,
      autoIncrement: true
    },
    Nickname: DataTypes.STRING,
    FirstCard: DataTypes.STRING,
    SecondCard: DataTypes.STRING
  }, {
    timestamps: false
  });
  Player.associate = function(models) {
    // associations can be defined here
  };
  return Player;
};