/** Declar: api uri and personnage datatable */
const uri = 'api/StarWars';
let personnages = [];


/**
 * Create a function to get fetch api data into our two functions _displayCount and _displayItems .
 */
function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

/**
 * Create a function to get personnage numbers.
 */

function _displayCount(itemCount) {
    const name = (itemCount === 1) ? 'personnage' : 'personnages';

    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

/**
 * Create a function to dispaly personnage informations.
 */

function _displayItems(data) {
    const tBody = document.getElementById('personnages');
    tBody.innerHTML = '';

    _displayCount(data.length);


    data.forEach(item => {


        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        let textNode_name = document.createTextNode(item.name);
        td1.appendChild(textNode_name);

        let td2 = tr.insertCell(1);
        let textNode_height = document.createTextNode(item.height);
        td2.appendChild(textNode_height);

        let td3 = tr.insertCell(2);
        let textNode_mass = document.createTextNode(item.mass);
        td3.appendChild(textNode_mass);

        let td4 = tr.insertCell(3);
        let textNode_nbr_films = document.createTextNode(item.films.length);
        td4.appendChild(textNode_nbr_films);

    });

    personnages = data;
}