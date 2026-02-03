//STEP 2: Access DOM Objects (Create references to DOM elements)

const eventList=document.getElementById("eventList");
const eventTitle=document.getElementById("eventTitle");
const eventDesc=document.getElementById("eventDesc");
const countSpan=document.getElementById("count");
const registerBtn=document.getElementById("registerBtn");
const unregisterBtn=document.getElementById("unregisterBtn");
const addEventBtn=document.getElementById("addEventBtn");
//STEP 3: Event Data (JavaScript Object)
let events=[{id:1,title:"Music",desc:"Live music",participants:0},
    {id:2,title:"Yoga",desc:"Morning Yoga for health",participants:0},
    {id:3,title:"Art",desc:"Hand crafts",participants:0}
];
let selectedEvent=null;
//STEP 4: Display Events Dynamically (Add Elements)
function displayEvents() {
  eventList.innerHTML = "";

  events.forEach(event => {
    const li = document.createElement("li");
    li.textContent = event.title;

    li.addEventListener("click", () => selectEvent(event));
    eventList.appendChild(li);
  });
}
displayEvents();
//STEP 5: Handle Event Selection (Modify Content)
function selectEvent(event) {
  selectedEvent = event;
  eventTitle.textContent = event.title;
  eventDesc.textContent = event.desc;
  countSpan.textContent = event.participants;
}
//STEP 6: Register for Event (Modify DOM Content)
registerBtn.addEventListener("click", () => {
  if (!selectedEvent) {
    alert("Please select an event first");
    return;
  }

  selectedEvent.participants++;
  countSpan.textContent = selectedEvent.participants;
});

// STEP 7: Unregister from Event (Remove / Modify)
unregisterBtn.addEventListener("click", () => {
  if (!selectedEvent) {
    alert("Please select an event first");
    return;
  }

  if (selectedEvent.participants > 0) {
    selectedEvent.participants--;
    countSpan.textContent = selectedEvent.participants;
  }
});

// STEP 8: Add New Event Dynamically (Create + Append)
addEventBtn.addEventListener("click", () => {
  const title = prompt("Enter event title");
  const desc = prompt("Enter event description");

  if (!title || !desc) {
    alert("Event title and description required");
    return;
  }

  const newEvent = {
    id: events.length + 1,
    title,
    desc,
    participants: 0
  };

  events.push(newEvent);
  displayEvents();
});


