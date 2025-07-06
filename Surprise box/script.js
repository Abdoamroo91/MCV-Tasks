const surprises = [
    "Ur a Champ, keep that bud 🦾",
    "U deserve better buddy 😘",
    "Love yourself more before you get old 🧑‍🦳"
];

function getSurprise() {
    return new Promise((res) => {
        setTimeout(() => {
            const randomNum = Math.floor(Math.random() * 3);
            res(surprises[randomNum]);
        }, 2000);
    });
}

document.getElementById("show").addEventListener("click", () => {
    const message = document.getElementById("surpise");
    message.textContent = "Loading... 🤌";
    getSurprise().then((msg) => {
        message.textContent = msg;
    });
});
