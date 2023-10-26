const alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

function newAlphabet(keyChar) { //Создание нового алфавита
    let newAlphabet = "";
    let keyNumber = alphabet.indexOf(keyChar, 0);

    for (let j = 0; keyNumber + j < alphabet.length; j++) //Заполняем первую половину
        newAlphabet += alphabet[keyNumber + j];

    for (let j = 0; j < keyNumber; j++) //Заполняем вторую половину
        newAlphabet += alphabet[j];
    return newAlphabet;
}

function isLetter(char) { //Проверка, является ли символ буквой
    return char.toLowerCase() != char.toUpperCase();
}

function isUpperCase(char) { //Проверка, является ли буква заглавной
    return char == char.toUpperCase();
}

function isRussian(message) { //Проверка, написано ли сообщение на кириллице
    let lowerCaseLetter = "";
    for (let i = 0; i < message.length; i++) {
        if (isLetter(message[i])) {
            lowerCaseLetter = message[i].toLowerCase();
            if (alphabet.indexOf(lowerCaseLetter, 0) == -1)
                return false;
        }
    }
    return true;
}

function codeVigenereSquare(key, message) { //Декодирование квадратом Виженера
    let changedAlphabet = "";
    let messageCharNumber;
    let codedMessage = "";
    let upperCaseFlag = false;
    let lowerCaseLetter = "";
    let j = 0;

    for (let i = 0; i < message.length; i++) {
        if (isLetter(message[i])) {
            if (isUpperCase(message[i]))
                upperCaseFlag = true;
            lowerCaseLetter = message[i].toLowerCase();
            messageCharNumber = alphabet.indexOf(lowerCaseLetter, 0);
            changedAlphabet = newAlphabet(key[j]);
            if (upperCaseFlag)
                codedMessage += changedAlphabet[messageCharNumber].toUpperCase();
            else
                codedMessage += changedAlphabet[messageCharNumber];
            j++;
        } else
            codedMessage += message[i];
        if (j == key.length)
            j = 0;
        upperCaseFlag = false;
    }
    return codedMessage;
}

function decodeVigenereSquare(key, message) { //Кодирование квадратом Виженера
    let changedAlphabet = "";
    let messageCharNumber;
    let codedMessage = "";
    let upperCaseFlag = false;
    let lowerCaseLetter = "";
    let j = 0;

    for (let i = 0; i < message.length; i++) {
        if (isLetter(message[i])) {
            if (isUpperCase(message[i]))
                upperCaseFlag = true;
            lowerCaseLetter = message[i].toLowerCase();
            changedAlphabet = newAlphabet(key[j]);
            messageCharNumber = changedAlphabet.indexOf(lowerCaseLetter, 0);
            if (upperCaseFlag)
                codedMessage += alphabet[messageCharNumber].toUpperCase();
            else
                codedMessage += alphabet[messageCharNumber];
            j++;
        } else
            codedMessage += message[i];
        if (j == key.length)
            j = 0;
        upperCaseFlag = false;
    }
    return codedMessage;
}


function toCode() { //Кодирование и вывод ответа по кнопке
    let resultText = document.getElementById("resultText");
    let resultValue = document.getElementById("resultValue");
    let message = document.getElementById("message").value;
    let key = document.getElementById("key").value;
    console.log(key);
    if (key) {
        if (isRussian(message) && isRussian(key)) {
            resultText.innerHTML = "Зашифрованное сообщение: <br>"
            resultValue.innerHTML = codeVigenereSquare(key, message);
        } else {
            resultText.innerHTML = "Пожалуйста, используйте только русские буквы";
            resultValue.innerHTML = "";
        }
    } else {
        resultText.innerHTML = "Введите ключ шифрования"
        resultValue.innerHTML = "";
    }
}

function toDecode() { //Декодирование и вывод ответа по кнопке
    let resultText = document.getElementById("resultText");
    let resultValue = document.getElementById("resultValue");
    let message = document.getElementById("message").value;
    let key = document.getElementById("key").value;
    if (key) {
        if (isRussian(message) && isRussian(key)) {
            resultText.innerHTML = "Расшифрованное сообщение: <br>"
            resultValue.innerHTML = decodeVigenereSquare(key, message);
        } else {
            resultText.innerHTML = "Пожалуйста, используйте только русские буквы";
            resultValue.innerHTML = "";
        }
    } else {
        resultText.innerHTML = "Введите ключ шифрования"
        resultValue.innerHTML = "";
    }
}