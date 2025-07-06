const options = {
    method: 'GET',
    headers: {
        accept: 'application/json',
        Authorization: 'Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIzNzM1Zjg4YjY3NTIzNjAxNzViNTE1NzZjODM3ZDZkYiIsIm5iZiI6MTc1MTgwODM0MS42MTc5OTk4LCJzdWIiOiI2ODZhNzk1NTJhNjQ0YzY5MDk5YTNiNTEiLCJzY29wZXMiOlsiYXBpX3JlYWQiXSwidmVyc2lvbiI6MX0.YggY-5dbDxfcN4flCUlvvRxtWbrjDBAqQGLCfMfoKYs'
    }
};

fetch('https://api.themoviedb.org/3/movie/now_playing?language=en-US&page=1', options)
    .then(res => res.json())
    .then(res => {
        const moviesContainer = document.getElementById("movies");

        const movies = res.results;

        movies.forEach(movie => {
            const movieCard = document.createElement("div");
            movieCard.classList.add("col-md-3", "mb-4");

            const imagePath = movie.poster_path 
                ? `https://image.tmdb.org/t/p/w500${movie.poster_path}`
                : 'https://via.placeholder.com/500x750?text=No+Image';

            movieCard.innerHTML = `
                <div class="card h-100 bg-dark text-light border-light">
                    <img src="${imagePath}" class="card-img-top" alt="${movie.title}" style="height: 350px; object-fit: cover;">
                    <div class="card-body d-flex flex-column">
                        <h5 class="card-title">${movie.title}</h5>
                        <p class="card-text flex-grow-1">${movie.overview.slice(0, 100)}...</p>
                        <p class="fw-bold">⭐ Rating: ${movie.vote_average}</p>
                    </div>
                </div>
            `;

            moviesContainer.appendChild(movieCard);
        });
    })
    .catch(err => console.error(err));
