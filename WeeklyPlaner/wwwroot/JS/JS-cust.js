function onCopyFromElement(id) {

    var range = document.createRange();
    range.selectNode(document.getElementById(id));
    window.getSelection().removeAllRanges(); // clear current selection
    window.getSelection().addRange(range); // to select text
    document.execCommand("copy");
    window.getSelection().removeAllRanges();// to deselect
}

async function onCopyFromString(stringText) {

    await navigator.clipboard.writeText(stringText);

}

function resizeGridItem(item) {
    grid = document.getElementsByClassName("grid")[0];
    rowHeight = parseInt(window.getComputedStyle(grid).getPropertyValue('grid-auto-rows'));
    rowGap = parseInt(window.getComputedStyle(grid).getPropertyValue('grid-row-gap'));
    rowSpan = Math.ceil((item.querySelector('.content').getBoundingClientRect().height + rowGap) / (rowHeight + rowGap));
    item.style.gridRowEnd = "span " + rowSpan;
    console.log(rowSpan)
}

async function resizeAllGridItems() {
    allItems = await document.getElementsByClassName("grid-item");
    for (x = 0; x < allItems.length; x++) {
        resizeGridItem(allItems[x]);
    }
}

//window.onload = function () {
//    console.log(window.document.body.onload)
//    window.document.body.onload = resizeAllGridItems();
//};
//window.onload = resizeAllGridItems();
window.addEventListener("resize", () => resizeAllGridItems());

function getElementDimension() {
    const dimention = document.querySelector("body");

    if (dimention) {

        return dimention.offsetWidth;

    } else {
        return (null);
    }
}

