const newLetter = document.getElementById("newLetter");
const title = document.getElementById("title").innerHTML;
const txt = document.getElementById("txt").innerHTML;
let titleDone = false;

let letters = [
  "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", 
  "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
];

let braille = [
  "&#10241;", //a 
  "&#10243;", //b
  "&#10249;", //c
  "&#10265;", //d
  "&#10257;", //e
  "&#10251;", //f
  "&#10267;", //g
  "&#10259;", //h
  "&#10250;", //i
  "&#10266;", //j
  "&#10245;", //k
  "&#10247;", //l
  "&#10253;", //m
  "&#10269;", //n
  "&#10261;", //o
  "&#10255;", //p
  "&#10271;", //q
  "&#10263;", //r
  "&#10254;", //s
  "&#10270;", //t
  "&#10277;", //u
  "&#10279;", //v
  "&#10298;", //w
  "&#10285;", //x
  "&#10301;", //y
  "&#10293;", //z
]

const getBraille = (char) => {
  char = char.toUpperCase();
  for(let i = 0; i <= letters.length; i++)
  {
    if(char == letters[i])
    {
      return braille[i];
    }
  }
  return "";
}

let txtArr = title.split('');
let i = 0;

const read = () => {
  setTimeout(() => {
    if(txtArr[i] != " "){
      let newBr = getBraille(txtArr[i]);
      newLetter.innerHTML = newBr;
    }else{
      newLetter.innerHTML = " ";
    }

    let newChar = txtArr[i];
    let newArr = txtArr;
    console.log(newArr);
    newArr[i] = '<span class="Outline">' + newChar + '</span>';
    let newTxt = newArr.toString();
    console.log(newTxt);

    i++

    if(i < txtArr.length)
    {
      read();
    }
  }, 5000);
}

read();