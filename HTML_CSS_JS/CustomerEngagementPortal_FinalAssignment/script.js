document.getElementById("userForm").addEventListener("submit", function (e) {
  e.preventDefault();

  let name = document.getElementById("name").value;
  let email = document.getElementById("email").value;

  if (name === "" || email === "") {
    alert("All fields are required");
  } else {
    alert("Form submitted successfully");
  }
});

// Async Fetch Example
fetch("https://jsonplaceholder.typicode.com/users")
  .then(response => response.json())
  .then(data => console.log("Fetched Users:", data))
  .catch(error => console.error("Error:", error));
