# BSMAPI - Borealis (Game)server Manager API
Just a simple API backend for the Borealis Gameserver Manager.

## Concept
The point behind this project is to provide a backend for the client application to fetch data from on the fly, thus removing the need to push data with app updates (the app can just check this bad boy for new stuff). It'll store server configurations, and that's about it, really. There's some foundation for other concepts to be introduced at a later point (authentication, etc.)

## Installation
1. Clone this repository: `git clone https://github.com/SirHauteclaire/bsmapi`
2. Move into the directory (I shouldn't need to tell you how to do this).
3. Run `npm install` to download dependencies.
4. Run `node app` to start the API.  

It'll begin listening on whatever port/ip is specified in the config file (storage/config.json).

## Endpoints 

**[GET] /config/:appid/:format**  
Sends the requested :appid in the supplied :format. If nothing is specified, the server will return JSON. 

**[GET] /index**  
Returns an index of all configs available on the server.

**[ANY] /areyoualive**
yes

## TODO
- Create a web-based config creator.
- ~~Implement multiple response formats (XML, JSON, YAML, etc).~~
- Implement actual error handling instead of letting the user deal with it.
- Clean up codebase so it doesn't look like one of my essays.

## Future of BSMAPI
As it stands, my time is very limited. I'm not available to do much what with classes and stuff, and I'm also making huge life moves. If you feel the codebase can be improved, please feel free to do so. PRs are always appreciated!

I will take some time where I can to do some fixes, but one day I hope to rewrite the entire thing. Care to help me?
