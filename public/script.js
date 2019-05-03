let container;
let xhr;
let card;
let nickname;

function loadCards() {

    xhr = new XMLHttpRequest();
    xhr.open('GET', 'http://37.187.181.129:8080/api/player/get-info');
    xhr.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded');
    xhr.send(null); 
    xhr.addEventListener('readystatechange', () => {

        if (xhr.readyState === 4 && xhr.responseText) {
            let response = JSON.parse(xhr.responseText);

            for (let i = 1; i <= 10; i++) {
                for (let j = 1; j <= 2; j++) {
                    container = document.querySelector(`#p${i}c${j}`);
                    if (j == 1) {
                        card = response.players[i-1].FirstCard;
                    } else if (j == 2) {
                        card = response.players[i-1].SecondCard;
                    }
                    container.innerHTML = `<img src="assets/poker-cards/${card}.png" class="card">`;
                }
                nickname = response.players[i-1].Nickname;
                
                if (nickname == 'null') {
                    document.querySelector(`#p${i}`).style.display = 'none';
                } else {
                    document.querySelector(`#p${i}`).style.display = 'block';
                    document.querySelector(`#player${i}`).innerHTML = `${i}. ${nickname}`;
                }
            }
        }

    });

}

setInterval(loadCards, 1000);