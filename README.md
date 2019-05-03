# Poker Displayer

Poker Displayer is a web interface with green screen displaying player cards, selected from software

## Installation

```bash
npm install
```

## Usage
Go to `api/config/config-example.json`, rename the file by taking off `-example` and replace information in the file by your database configuration and create all the 3 database.

Then run these commands :

```bash
cd api
sequelize db:migrate
```

And it should work

```bash
node app.js
```

You have to make your own software to access the API (this is just the api and the web renderer)

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)

###### Made with 💜 by Kaiiso