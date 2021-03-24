function showModal(id, task){
    console.log(id + " " + task);
    var modal = document.getElementById("editModal");
    document.getElementById("updateTask").value = task;
    document.getElementById("updateSubmit").setAttribute("onclick", "putTask");
    modal.style.display = "block";

    var span = document.getElementsByClassName("class")[0;
    
}

function closeModal(){
    var modal = document.getElementById("editModal");
}