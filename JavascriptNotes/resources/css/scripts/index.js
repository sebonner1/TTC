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
        task: "Conduct Analyze Stage Gate"
    }
]
function handleOnLoad()
{
    populateTable();
}

function populateTable()
{
    let html = "<table class = \"halfpage\">";
    html += "<tr><th>ID</th><th>Task</th><th>Complete Task</th></tr>";
    array.forEach(task => {
        html += "<tr><td>"+task.id+"</td>";
        html += "<td>"+task.task+"</td>";
        html += "<td><button onclick=\"handleComplete("+task.id+")\">Complete</button></td></tr>"
    });
    html += "</table>";
    document.getElementById("table").innerHTML = "My table will go here";
}

function handleComplete(id){
    tasks = tasks.filter(task => {
        console.log(task.id + " " + id);

        return task.id != id
    });
    populateTable();
}

function handleAddTasl(){
    let inputTask = document.getElementById("task").value;
    maxId++;
    let newTask = {
        id: "1",
        task: inputTask
    };
    tasks.push(newTask);
    populateTable();
}