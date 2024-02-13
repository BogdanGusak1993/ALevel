let usersData = [];

// Define a function to fetch users data from the API
const fetchUsersData = async () => {
  try {
    const response = await fetch('https://reqres.in/api/users');
    if (!response.ok) {
      throw new Error('Failed to fetch users data');
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
  .then(users => {
    // Update usersData array with the fetched data
    usersData = users.map(user => ({
      id: user.id,
      email: user.email,
      first_name: user.first_name,
      last_name: user.last_name
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
                                <h5 class="card-title">${user.first_name} ${user.last_name}</h5>
                                <p class="card-text">${user.email}</p>
                            </div>
                        </div>
                    </div>`;
        dataCards.innerHTML += card;
    });
}

function populatePagination(data) {
    const pagination = document.getElementById('pagination');
    pagination.innerHTML = '';

    const itemsPerPage = 3; // Number of users to display per page
    const totalPages = Math.ceil(data.length / itemsPerPage);

    for (let page = 1; page <= totalPages; page++) {
        const li = document.createElement('li');
        li.classList.add('page-item');

        const button = document.createElement('button');
        button.textContent = page;
        button.classList.add('page-link');
        button.addEventListener('click', () => {
            showPage(page, data, itemsPerPage);
        });

        li.appendChild(button);
        pagination.appendChild(li);
    }

    // Add next and previous buttons
    const prevButton = createNavigationButton('Previous', () => {
        const currentPage = getCurrentPage();
        if (currentPage > 1) {
            showPage(currentPage - 1, data, itemsPerPage);
        }
    });

    const nextButton = createNavigationButton('Next', () => {
        const currentPage = getCurrentPage();
        if (currentPage < totalPages) {
            showPage(currentPage + 1, data, itemsPerPage);
        }
    });

    pagination.insertBefore(prevButton, pagination.firstChild);
    pagination.appendChild(nextButton);
}

function createNavigationButton(label, onClick) {
    const li = document.createElement('li');
    li.classList.add('page-item');

    const button = document.createElement('button');
    button.textContent = label;
    button.classList.add('page-link');
    button.addEventListener('click', onClick);

    li.appendChild(button);
    return li;
}

function getCurrentPage() {
    const activePage = document.querySelector('.page-item.active');
    return activePage ? parseInt(activePage.textContent) : 1;
}

function showPage(pageNumber, data, itemsPerPage) {
    const startIndex = (pageNumber - 1) * itemsPerPage;
    const endIndex = startIndex + itemsPerPage;
    const usersOnPage = data.slice(startIndex, endIndex);
    // Use usersOnPage to display users on the current page
    console.log('Displaying users on page', pageNumber, ':', usersOnPage);
}

//Event listener for stating page
document.addEventListener('DOMContentLoaded', () => {
    const dataTab = document.querySelector('[data-bs-target="#data"]');
    const event = new Event('shown.bs.tab', {
        bubbles: true,
        cancelable: true
    });
    dataTab.dispatchEvent(event);
});

// Event listener for tab change
document.querySelectorAll('[data-bs-toggle="tab"]').forEach(tab => {
    tab.addEventListener('shown.bs.tab', function (event) {
        if (event.target.getAttribute('aria-controls') === 'data') {
            populateDataCards(usersData); // Populate data cards when 'Data' tab is shown
            populatePagination(usersData); // Populate pagination when 'Data' tab is shown
        }
    });
});

// Form validation
document.getElementById('input-form').addEventListener('submit', function (event) {
    event.preventDefault();
    // Validation logic goes here
});
