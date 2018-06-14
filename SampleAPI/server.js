var express = require('express');
var app = express();
var bodyParser = require("body-parser")
var userEngine = require('./userData');

app.use(bodyParser.json());

app.listen(3000,function(){
	console.log("Listening 3000");
});


//  Get Request 
app.get("/users",function(req,res){

	console.log(req);
	var response = userEngine.getUserEntries();
    res.json(response);
});


//  Get Request by ID
app.get("/users/:id",function(req,res){

	console.log(req);
	var response = userEngine.getUserEntry(req.params.id);
    res.json(response);
});


//  POST Request
app.post('/users', function (req, res) {
	
	console.log(req);
    var response = userEngine.CreateUserEntry(req.body);
    res.json(response);
});


//Put Request
app.put('/users/:id', function (req, res) {
  
	console.log(req);
    var response = userEngine.UpdateUserEntry(req.params.id,req.body)
    res.json(response);
});


//  Delete Request
app.delete('/users/:id', function (req, res) {
  
  userEngine.DeleteUserEntry(req.params.id);
  res.send(req.params.id + " Delete succesfully!");

});
