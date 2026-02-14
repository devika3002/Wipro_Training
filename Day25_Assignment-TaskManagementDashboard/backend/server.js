const express = require("express");
const http = require("http");
const { Server } = require("socket.io");
const cors = require("cors");

const app = express();
const server = http.createServer(app);

const io = new Server(server, {
  cors: { origin: "*" },
});

app.use(cors());
app.use(express.json());

let tasks = [];

io.on("connection", (socket) => {
  console.log("User connected:", socket.id);

  socket.emit("loadTasks", tasks);

  // Add Task
  socket.on("addTask", (task) => {
    task.status = "Pending";   // default status
    tasks.push(task);
    io.emit("taskUpdated", tasks);
    io.emit("notify", `New task assigned to ${task.assignee}`);
  });

  // Delete Task
  socket.on("deleteTask", (taskId) => {
    tasks = tasks.filter(task => task.id !== taskId);
    io.emit("taskUpdated", tasks);
  });

  // Edit Task
  socket.on("editTask", (updatedTask) => {
    tasks = tasks.map(task =>
      task.id === updatedTask.id ? updatedTask : task
    );
    io.emit("taskUpdated", tasks);
  });

  // Toggle Status
  socket.on("toggleStatus", (taskId) => {
    tasks = tasks.map(task =>
      task.id === taskId
        ? { ...task, status: task.status === "Pending" ? "Completed" : "Pending" }
        : task
    );
    io.emit("taskUpdated", tasks);
  });

  socket.on("disconnect", () => {
    console.log("User disconnected");
  });
});

server.listen(5000, () => {
  console.log("Server running on port 5000");
});