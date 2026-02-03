fetch("https://dummy.restapiexample.com/api/v1/employees")
    .then(function(response) {
        return response.json();  //this converts response to json
    })
    .then(function(data) {
        console.log("Employee Data:");
        console.log(data);  //display data in console
    })
    .catch(function(error) {
        console.log("Error Fetching data:",error);
    });