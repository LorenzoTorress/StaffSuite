let cardEmpleado = document.getElementById("BotonEmpleados")
let cardDepartamento = document.getElementById("BotonDepartamento")
let cardEncargado = document.getElementById("BotonEncargado")

cardEmpleado.addEventListener("click", () => redirectToEmpleados())
cardDepartamento.addEventListener("click", () => redirectToDepartamentos())
cardEncargado.addEventListener("click", () => redirectToEncargados())

function redirectToEmpleados() {
    window.location.href = 'Empleados/Index'
}
function redirectToDepartamentos() {
    window.location.href = 'Departamentos/Index'
}
function redirectToEncargados() {
    window.location.href = 'EmpleadoDepartamentos/Index'
}