// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function convert() {
    var weight;
    var volume;
    var selectedWeightType;
    var selectedVolumeType;
    var ounces;
    var pounds;
    var grams;
    var kilograms;
    var milliliters;
    var liters;
    var ouncesVolume;
    var pints;

    getConversions();


    function getConversions() {
        weight = document.getElementById("weightInput").value;
        volume = document.getElementById("volumeInput").value;
        let weightType = document.getElementById("weightType");
        selectedWeightType = weightType.options[weightType.selectedIndex].value;
        let volumeType = document.getElementById("volumeType");
        selectedVolumeType = volumeType.options[volumeType.selectedIndex].value;
        

        if (weight != "" && weight != null) {
            convertWeight();
        }

        if (volume != "" && volume != null) {
            convertVolume();
        }

        displayConversions();

    }

    function convertWeight() {
        switch (selectedWeightType) {
            case "ounces":
                pounds = weight / 16;
                grams = weight * 28.35;
                kilograms = weight / 35.274;
                ounces = weight;
                break;
            case "pounds":
                pounds = weight;
                grams = weight * 453.592;
                kilograms = weight / 2.205;
                ounces = weight * 16;
                break;
            case "grams":
                pounds = weight / 453.592;
                grams = weight;
                kilograms = weight / 1000;
                ounces = weight / 28.35;
                break;
            case "kilograms":
                pounds = weight * 2.205;
                grams = weight * 1000;
                kilograms = weight;
                ounces = weight * 35.274;
                break;
        }

    }

    function convertVolume() {
        switch (selectedVolumeType) {
            case "milliliters":
                milliliters = volume;
                liters = volume / 1000;
                ouncesVolume = volume / 29.574;
                pints = volume / 473.176;
                break;
            case "liters":
                milliliters = volume * 1000;
                liters = volume;
                ouncesVolume = volume * 33.814;
                pints = volume * 2.113;
                break;
            case "ounces":
                milliliters = volume * 29.5735;
                liters = volume / 33.814;
                ouncesVolume = volume;
                pints = volume / 16;
                break;
            case "pints":
                milliliters = volume * 473.176;
                liters = volume / 2.113;
                ouncesVolume = volume * 16;
                pints = volume;
                break;
        }
    }

    function displayConversions() {
        let weightConversion = document.getElementById("weightConversions");
        let volumeConversion = document.getElementById("volumeConversions");
       
        if (weight != "" && weight != null) {
            weightConversion.innerHTML = "<h4>Ounces: </h4>" + ounces + "\n" +
            "<h4>Pounds: </h4>" + pounds + "\n" + "<h4>Grams: </h4>" + grams + "\n" +
            "<h4>Kilograms: </h4>" + kilograms;
        }
        if (volume != "" && volume != null) {
            volumeConversion.innerHTML = "<h4>Milliliters: </h4>" + milliliters + "\n" +
                "<h4>Liters: </h4>" + liters + "\n" + "<h4>Ounces: </h4>" + ouncesVolume + "\n" +
                "<h4>Pints: </h4>" + pints;
        }
        
        
    }
}

