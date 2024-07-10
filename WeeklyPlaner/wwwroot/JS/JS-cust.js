function onCopyFromElement(id) {

    var range = document.createRange();
    range.selectNode(document.getElementById(id));
    window.getSelection().removeAllRanges(); // clear current selection
    window.getSelection().addRange(range); // to select text
    document.execCommand("copy");
    window.getSelection().removeAllRanges();// to deselect
}

async function onCopyFromString(stringText) {

    console.log(stringText);

    await navigator.clipboard.writeText(stringText);

}