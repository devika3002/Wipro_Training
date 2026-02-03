document.getElementById("loadUserBtn").addEventListener("click", function () {

  fetch("https://randomuser.me/api/")
    .then(function (response) {
      return response.json();
    })
    .then(function (data) {

      const user = data.results[0];

      document.getElementById("name").innerText =
        "Name: " + user.name.first + " " + user.name.last;

      document.getElementById("email").innerText =
        "Email: " + user.email;

      document.getElementById("photo").src =
        user.picture.large;
    })
    .catch(function (error) {
      console.log("Error:", error);
    });

});