function  callme(){
	var name=document.getElementById("text").value.trim() ;
	var pr=document.getElementById("name1").value.trim();
	if(name.length==0){
	alert("Please enter the name");
	return false;}

	
	else if(name.length<2||name.length>65){
	alert("Name cannot be less than 2 character and more than 65 character");
	return false;
	}
	
	
	if(isNaN(pr)){
	alert("Price should be in numeric");
	return false;
} if (pr==0){
alert("Price cannot be Zero");
return false;}

	return true;



}
 