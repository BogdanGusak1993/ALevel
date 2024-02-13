let resourcesData = [];

// Define a function to fetch users data from the API
const fetchResourcesData = async () => {
  try {
    const response = await fetch('https://reqres.in/api/unknown');
    if (!response.ok) {
      throw new Error('Failed to fetch resources data');
    }
    const data = await response.json();
    return data.data; // Extract the 'data' property from the response
  } catch (error) {
    console.error('Error fetching users data:', error);
    throw error; // Throw the error for handling elsewhere
  }
};

// Call the function to fetch users data and update usersData array
fetchUsersData()
  .then(resources => {
    // Update usersData array with the fetched data
    resourcesData = resources.map(resource => ({
      id: resource.id,
      name: resource.name,
      year: resource.year,
      color: resource.color,
      pantone_value: resource.pantone_value
    }));
  })
  .catch(error => {
    // Handle the error if fetching data fails
    console.error('Error fetching users data:', error);
  });

// Function to populate data cards
function populateDataCards(data) {
    const dataCards = document.getElementById('data-cards');
    dataCards.innerHTML = '';
    data.forEach(user => {
        const card = `<div class="col-md-4">
                        <div class="card mb-4">
                            <div class="card-body">
                                <h5 class="card-title">${resource.name} ${resource.year}</h5>
                                <p class="card-text">${resource.pantone_value}</p>
                            </div>
                        </div>
                    </div>`;
        dataCards.innerHTML += card;
    });
}

// Function to populate pagination
function populatePagination(data) {
    const pagination = document.getElementById('pagination');
    pagination.innerHTML = '';
    // Pagination logic goes here
}

// Event listener for tab change
document.querySelectorAll('[data-bs-toggle="tab"]').forEach(tab => {
    tab.addEventListener('shown.bs.tab', function (event) {
        if (event.target.getAttribute('aria-controls') === 'data') {
            populateDataCards(resourcesData); // Populate data cards when 'Data' tab is shown
            populatePagination(resourcesData); // Populate pagination when 'Data' tab is shown
        }
    });
});

// Form validation
document.getElementById('input-form').addEventListener('submit', function (event) {
    event.preventDefault();
    // Validation logic goes here
});
