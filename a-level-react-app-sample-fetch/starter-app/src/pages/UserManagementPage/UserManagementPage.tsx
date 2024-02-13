import React, { useState, useEffect, ReactElement, FC} from 'react';
import { TextField, Button, Container, Grid } from '@mui/material';
import axios from 'axios';

interface User {
  id: number;
  email: string;
}

interface Resource {
  id: number;
  name: string;
}

const UserManagementPage: FC<any> = (): ReactElement => {
  const [users, setUsers] = useState<User[]>([]);
  const [resources, setResources] = useState<Resource[]>([]);
  const [newUser, setNewUser] = useState<Partial<User>>({});

  // Fetch users and resources on component mount
  useEffect(() => {
    fetchUsers();
    fetchResources();
  }, []);

  const fetchUsers = async () => {
    try {
      const response = await axios.get<User[]>('/api/modules/users');
      setUsers(response.data);
    } catch (error) {
      console.error('Error fetching users:', error);
    }
  };

  const fetchResources = async () => {
    try {
      const response = await axios.get<Resource[]>('/api/modules/resources');
      setResources(response.data);
    } catch (error) {
      console.error('Error fetching resources:', error);
    }
  };

  const createUser = async () => {
    try {
      const response = await axios.post('/api/modules/users', newUser);
      if (response.status === 201) {
        // Refresh the user list
        fetchUsers();
        // Clear the input fields
        setNewUser({});
      } else {
        console.error('Failed to create user');
      }
    } catch (error) {
      console.error('Error creating user:', error);
    }
  };

  const updateUser = async (userId: number, updatedUser: Partial<User>) => {
    try {
      const response = await axios.put(`/api/modules/users/${userId}`, updatedUser);
      if (response.status === 200) {
        // Refresh the user list
        fetchUsers();
      } else {
        console.error('Failed to update user');
      }
    } catch (error) {
      console.error('Error updating user:', error);
    }
  };

  const handleInputChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setNewUser({ ...newUser, [name]: value });
  };

  const validateEmail = (email: string): boolean => {
    // Basic email validation
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
  };

  const handleCreateUser = () => {
    if (!validateEmail(newUser.email || '')) {
      console.error('Invalid email format');
      return;
    }
    createUser();
  };

  const handleUpdateUser = (userId: number, updatedEmail: string) => {
    if (!validateEmail(updatedEmail)) {
      console.error('Invalid email format');
      return;
    }
    updateUser(userId, { email: updatedEmail });
  };

  return (
    <Container>
      <Grid container spacing={2}>
        <Grid item xs={12}>
          <h1>Users</h1>
          {users.map((user) => (
            <div key={user.id}>
              {user.email}{' '}
              <Button
                variant="outlined"
                onClick={() => handleUpdateUser(user.id, 'newemail@example.com')}
              >
                Update Email
              </Button>
            </div>
          ))}
        </Grid>
        <Grid item xs={12}>
          <h1>Resources</h1>
          {resources.map((resource) => (
            <div key={resource.id}>{resource.name}</div>
          ))}
        </Grid>
        <Grid item xs={12}>
          <h1>Create User</h1>
          <TextField
            name="email"
            label="Email"
            value={newUser.email || ''}
            onChange={handleInputChange}
          />
          {/* Add more fields for user creation */}
          <Button variant="contained" color="primary" onClick={handleCreateUser}>
            Create User
          </Button>
        </Grid>
      </Grid>
    </Container>
  );
}

export default UserManagementPage;
