const express = require("express");
const http = require("http");
const socketIo = require("socket.io");
const cors = require("cors");

const app = express();
app.use(cors());

const server = http.createServer(app);

const io = socketIo(server, {
  cors: {
    origin: "*",
  },
});

io.on("connection", (socket) => {
  console.log("User connected");

  socket.on("getStock", (symbol) => {
    console.log("Stock requested:", symbol);

    setInterval(() => {
      const fakePrice = (Math.random() * 1000).toFixed(2);

      socket.emit("stockUpdate", {
        symbol,
        price: fakePrice,
      });
    }, 3000);
  });
});

server.listen(5000, () => {
  console.log("Server running on port 5000");
});