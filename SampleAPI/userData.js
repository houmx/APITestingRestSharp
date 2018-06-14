// userData.js文件

var entries = [
	{"id":1, "firstname":"Mark", "lastname":"Hou", "phone":"02111013"},
	{"id":2, "firstname":"Hadd", "lastname":"sun", "phone":"0212013"}
];

exports.getUserEntries = function (){
   return entries;
}

exports.getUserEntry = function (id){
   for(var i=0; i < entries.length; i++){
      if(entries[i].id == id) 
      	var temp = entries[i];
   }
   return temp;
}

exports.CreateUserEntry = function(userInfo){

		userInfo.id = entries.length+1;
		entries.push(userInfo);
		return entries[entries.length-1];
}


exports.UpdateUserEntry = function(id,userInfo){
	for(var i=0; i< entries.length; i++){
		if(entries[i].id == id){
			entries[i].firstname = userInfo.firstname,
			entries[i].lastname = userInfo.lastname,
			entries[i].phone = userInfo.phone
			var temp = entries[i];
		}
	}
	return temp;
}

exports.DeleteUserEntry = function(id){
	for(var i=0; i< entries.length; i++){
		if(entries[i].id == id){
			 entries.splice(i,1);
		}
	}
}