import React, { Component } from "react";

class UserList extends Component {

  componentDidMount() {
    console.log("UserList Component Mounted");
  }

  render() {
    return (
      <div>
        <h2>User List (Class Component)</h2>
        <ul>
          {this.props.users.map((user) => (
            <li key={user.id}>{user.name}</li>
          ))}
        </ul>
      </div>
    );
  }
}

export default UserList;