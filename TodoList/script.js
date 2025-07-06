let todos = [];

function loadTodos() {
    fetch('https://jsonplaceholder.typicode.com/todos')
        .then(res => res.json())
        .then(res => {
            todos = res.slice(0, 20);
            const todosContainer = document.getElementById("todos");
            todosContainer.innerHTML = "";
            todos.forEach(todo => {
                todosContainer.innerHTML += `
                    <div class="todo d-flex justify-content-between align-items-center p-2">
                        <p class="m-0">${todo.title}</p>
                        <button class="btn fs-6 ${todo.completed ? 'btn-success' : 'btn-danger'}">
                            ${todo.completed ? 'Done' : 'Pending'}
                        </button>
                    </div>
                `;
            })
        })
}
document.getElementById("load").addEventListener('click',async ()=>{
    await loadTodos()
})
