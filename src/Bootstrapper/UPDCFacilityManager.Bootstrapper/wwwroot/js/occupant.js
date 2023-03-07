
$(document).ready(function () {

  

 

});

const addCredential = (name) => {
    const message = `You are about to delete occupant: ${name}`
    //document.getElementById("user_name").innerHTML = message;
    $("#user_name").val(message);
    $("#exampleModal").modal('show');
}



