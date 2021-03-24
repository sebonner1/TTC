var maxId = 3;
tasks = [
    {
        id: "1",
        task: "Conduct Plan Stage Gate"
    },
    {
        id: "2",
        task: "Gather Requirements"
    },
    {
        id: "3",
        task: "Conduct Analysis Stage Gate"
    }
]

function handleOnLoad()
{
    populateTable();
}

function populateTable()
{
    let html = "<table class=\"halfpage\">";
    html += " <tr><th>ID</th><th>Task</th><th>Complete Task</th></tr>";
    tasks.forEach(task => {
        html+= "<tr><td>"+task.id+"</td>";
        html += "<td>" +task.task+ "</td>";
        html += "<td><button onclick=\"showModal("+task.id+",\""+task.task+"")\"">Edit</button></td></tr>"
    });
    html += "</table>"
    document.getElementById("table").innerHTML = html;
}

function handleComplete(id){
    tasks = tasks.filter(task => {
        console.log(task.id + " " + id);
        return task.id != id});
    populateTable();
}

function handleAddTask(){
    const taskApiUrl = "https://localhost:8080/api/task";
    let inputTask = document.getElementById("task").value;
    let newTask = {
        task: inputTask
    };
    tasks.push(newTask);
    populateTable();
}

fetch(taskApiUrl, {
    method: "POST",
    headers: {
        "Accept": 'application/json',
        "Content-Type": 'application/json',
    },
    body: JSON.stringify(newTask)
}),then(function(response){
    console.log(response);
    getTasks();
})