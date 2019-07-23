var chalk = require('chalk');
var fs = require('fs');
var path = require( 'path' );
var process = require( "process" );
var express = require('express');
var saimin = express();
var jsonxml = require('jsontoxml');
const config = JSON.parse(fs.readFileSync('storage/config.json'));
var moment = require('moment-timezone');
var os = require('os');
var request = require('request');

var debug = config.debug;
function getIp() {
	if(process.platform == "win32") {
		var networkInterfaces = os.networkInterfaces();
		return networkInterfaces['Ethernet'][1]['address'];
	} else {
		var networkInterfaces = os.networkInterfaces();
		return networkInterfaces['eth0'][0]['address'];
	}
}
function timestamp() {
  return moment().tz(config.timezone).format('LLLL z');
}
/*
function getLatestV() {
	var latestV = request("")
}
*/
//==============================================================//
// API REQUEST HANDLERS                                         //
//==============================================================//
// Fetches config files based on appid.
saimin.get('/config/:appid/:format', function (req, res) {
configdata = fs.readFile('./storage/configs/' + req.params.appid + '.json', 'utf8', (err, data) =>
{
	console.log(chalk.bgCyan(" INFO ") + " (" + timestamp() + ") " + chalk.bgBlue("[Got request for appID: " + req.params.appid + "]"));

	if (err) {
		res.send("404");
		console.log(chalk.bgRed(" ERROR ") + " (" + timestamp() + ") " + chalk.bgYellow("[Couldn't locate appID: " + req.params.appid + "]"));
	}
	else
	{
		//if :format isn't supplied, default to json.
		if(req.params.format == "json") {
			console.log(chalk.bgCyan(" INFO ") + " (" + timestamp() + ") " + chalk.bgBlue("[Sending config data (json) for appID: " + req.params.appid + "]"));
			res.send(data);
		} else if(req.params.format == "xml") {
			console.log(chalk.bgCyan(" INFO ") + " (" + timestamp() + ") " + chalk.bgBlue("[Sending config data (xml) for appID: " + req.params.appid + "]"));
			var xmldata = JSON.parse(data);
			if(debug == true){
				console.log(chalk.bgYellow("DEBUG") + " (" + timestamp() + ") " +  xmldata);
			}
			res.header('Content-Type','text/xml').send(jsonxml(xmldata))
		}

	}
});
});
saimin.get('/config/:appid', function (req, res) {
configdata = fs.readFile('./storage/configs/' + req.params.appid + '.json', 'utf8', (err, data) =>
{
	console.log(chalk.bgCyan(" INFO ") + " (" + timestamp() + ") " + chalk.bgBlue("[Got request for appID: " + req.params.appid + "]"));

	if (err) {
		res.send("404");
		console.log(chalk.bgRed(" ERROR ") + " (" + timestamp() + ") " + chalk.bgYellow("[Couldn't locate appID: " + req.params.appid + "]"));
	}
	else
	{
		res.send(data);
		console.log(chalk.bgCyan(" INFO ") + " (" + timestamp() + ") " + chalk.bgBlue("[Sending config data (json) for appID: " + req.params.appid + "]"));
	}
});
});

// Gets the index of all configs.
saimin.get('/index', function (req, res) {
var directory = "./storage/configs";
var indexlist = {}
fs.readdir( directory, function( err, files )
{
	files.forEach(function(file, index)
	{
		var indexid = file.replace(".json", "");
		var jsonfile = require('./storage/configs/' + indexid + '.json');
		indexlist[indexid] = jsonfile.SERVER_type;
    });
        res.json(indexlist);
        console.log(chalk.bgCyan(" INFO ") + " (" + timestamp() + ") " + chalk.bgBlue("[Sending index...]"));
	});
});
/*
saimin.all('/update/:localversion', function (req, res) {
	var lv = req.params.localversion;
})
*/

// Launch the integrated server.
saimin.listen(config.port, config.host, function ()
{
	console.log(chalk.bgCyan(" INFO ") + " (" + timestamp() + ") " + "Borealis is listening on... " +
	"\n\t" + "Public IP: " + chalk.bgGreen(getIp() + ":" + config.port) +
	"\n\t" + "Local IP:  " + chalk.bgGreen("127.0.0.1:" + config.port));
});

// Respond with 410.
saimin.all('/', function (req, res)
{
	res.send('410');
})

// Check for Alive Status
saimin.all('/areyoualive', function (req, res)
{
	res.send("yes");
});


//==============================================================//
// API SHUTDOWN HANDLERS                                        //
//==============================================================//
// Handle Server Shutdown
process.on("SIGINT", function () {
	console.log(chalk.bgCyan(" INFO ") + " (" + timestamp() + ") " + chalk.bgRed("[Borealis Server Manager API: Shutting down...]"));
	process.exit();
});

// Handle Ctrl+C
if (process.platform === "win32")
{
	var rl = require("readline").createInterface({
	input: process.stdin,
	output: process.stdout
});
	rl.on("SIGINT", function ()
	{
		process.emit("SIGINT");
	});
}
