const nameInput=document.getElementById("name");
const emailInput=document.getElementById("email");
const serviceInput=document.getElementById("service");
const descriptionInput=document.getElementById("description");
const message=document.getElementById("message");
const statusList=document.getElementById("statusList");
let requests=[];
function showSection(id) {
    document.querySelectorAll("section").forEach(sec => {
        sec.classList.add("d-none");
    });
    document.getElementById(id).classList.remove("d-none");
}
//form validation
document.getElementById("requestForm").addEventListener("submit",function(e) {
    console.log("Submit clicked");
    e.preventDefault();
    const name=nameInput.value;
    const email=emailInput.value;
    const service=serviceInput.value;
    const description=description.value;
    if (!name || !email || !service || !description) {
        message.innerText = "All fields are required";
        message.style.color ="red";
        return;
    }
    const data = {name,email,service,description};
    requests.push(data);
    const li=document.createElement("li");
    li.innerText = `${name} - ${service}`;
    statusList.appendChild(li);
    showSection("status");
    message.innerText="Request submitted successfully";
    message.style.color="green";
    this.reset();
});
//Fetch daata
fetch("data.json")
    .then(res=>res.json())
    .then(data=> {
        const container=document.getElementById("serviceCards");
        data.forEach(service=> {
            container.innerHTML += `
            <div class="col-md-4">
            <div class="card mb-3">
            <div class="card-body">
            <h5>${service.name}</h5>
            <p>${service.desc}</p>
            <button class="btn btn-primary" onclick="showsection('request')">Request</button>
            </div>
            </div>
            </div>
            `;
        });

    })
    .catch(()=> {
        alert("Failed to load services");
    });