//logic for actions
//step1:append values
//step2:clear screen
//step3:perform calculations
function appendValue(value){
    //reading the values
    //using DOM we can read the value from the
    const el = document.getElementById("result");
    el.value += value;

}
function clearResult(){
    //setting the text box as blank -hence clearing value
    document.getElementById("result").value="";

}
function calculate(){
    //variables to hold expressions as well as output
    const expressions = document.getElementById("result").value;
    try {
        const output = eval(expressions);
        document.getElementById("result").value = output;
    } catch (err) {
        document.getElementById("result").value ="Error";
        console.error("Calculation error:",err);

    }
}