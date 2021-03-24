var fullAPIList;

function handleOnLoad()
{
    getAPIs();
}

function getAPIs()
{
    const allApiURL = "https://api.publicapis.org/entries";

    fetch(allApiURL).then(function(response){
        return response.json();
    }).then(function(json){
        fullAPIList = json.entries;
        populateTable(json.entries);
    }).catch(function(error){

    })
}

function populateTable(apiList)
{
    let html = "<table class=\"table-bordered table-hover\">";
    html += "<tr><th>API</th></tr><tr><th>Description</th></tr><tr><th>Link</th></tr>";
    apiList.foreach(api =>{
        html += "<tr><td>"+api.API+"</td>";
        html += "<tr><td>"+api.Description+"</td>";
        html += "<tr><td>"+api.Link+"</td></tr>";
    });
    html += "</table>";
    document.getElementById("apiTable").innerHTML = html;
}

function handleAllOnclick(){
    populateTable(fullAPIList);
}

function handleAnimalOnclick(){
    const result = fullAPIList.filter(api => api.Category = "Animals");
    populateTable(result);
}

function handleBookOnclick(){
    const result = fullAPIList.filter(api => api.Category = "Books");
    populateTable(result);
}