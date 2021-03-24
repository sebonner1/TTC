var count = 0;
function countMessage(){
    count++;
    let html = "The count is " + count;
    document.getElementById(welcomeMessage).innerHTML = html;
}