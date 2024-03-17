export function saveMessage(name) {
    //alert(name +  " has been saved successfully");
    document.getElementById("divServerValidations").innerText = name + " has been saved successfully";
}

export function setFocusOnElement(element) {
    element.focus();
}

export function getCities() {
    var cities = ['New York', 'Los Angeles', 'Minsk', 'Hrodno', 'Chicago'];
    return cities;
}