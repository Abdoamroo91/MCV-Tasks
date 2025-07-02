const wizardQuotes = [
    "By the flames of the phoenix, it shall be done!",
    "Magic is not just power — it is purpose.",
    "The stars foretell your path, if you know how to read them.",
    "Silence! I must concentrate the arcane energies.",
    "Even time must bow to the will of a true wizard.",
    "Speak friend, and enter… or face my wrath!",
    "Wands are for beginners — I wield the ancient tongue.",
    "A storm is coming, and I ride its lightning.",
    "Fools rush in where dragons tread lightly.",
    "Beware the calm — it's merely the eye of the spell."
];
// let btn = document.getElementById('btn')
// let quotesParagraph = document.getElementById('quotes')
// btn.addEventListener('click', ()=> {
//     let randomInt = Math.floor(Math.random()*9)
//     quotesParagraph.innerText = wizardQuotes[randomInt]
// })

let button = document.getElementById('launch')
let rocket = document.getElementById('rocket')
button.addEventListener('click', ()=> {
    rocket.classList.add('launched')
    console.log("pleasee ")
})
