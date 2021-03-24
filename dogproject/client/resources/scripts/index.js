function getDog(){
    const dogApiUrl = "https://localhost:5001/api/books";

    fetch(dogApiUrl).then(function(response){
        return response.json();
    }).then(function(json){
        console.log(json);
        const imageUrl = json[0].url;
        var html = "<img src= \"" + imageUrl + "\" style=\"width:100%\"></img>";
        const breedData = json[0].breeds[0];
        var breed; var weight; var lifeSpan;
        try{
            breed = breedData.name;
        }
        catch{
            breed = "Unknown";
        }
        try{
            weight = breedData.weight.imperial;
        }
        catch{
            lifeSpan = "Unknown";
        }
        try{
            lifeSpan = breedData.life_span;
        }
        catch{
            lifeSpan = "Unknown";
        }

        html += "<div class = \"container\">";
        html += "<div><p><b>Breed : </b>" + breed + "</p>";
        html += "<div><p><b>Normal Weight : </b>" + weight + "</p>";
        html += "<div><p><b>Normal Lifespan : </b>" + lifeSpan + "</p>";
        html += "</div>";

        document.getElementById("dogImage").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    })

}
function handleOnLoad()
{
     
}