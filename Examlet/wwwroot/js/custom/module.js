const btnAddCardEl = document.getElementById('btnAddCard');
const currentScript = document.currentScript;
const url = currentScript.getAttribute('data-controller-name');
btnAddCardEl.addEventListener('click', async function () {
    const resp = await fetch(url, { method:'GET' });
    const cardPartial = await resp.text();
    btnAddCardEl.insertAdjacentHTML('beforebegin', cardPartial);
});

function beforeSubmit() {
    const cardContainerEls = document.querySelectorAll("[data-card=\"container\"]");
    let idx = 0;
    for (let i = 0; i < cardContainerEls.length; i++) {
        const containerEl = cardContainerEls[i];
        const termEl = containerEl.querySelector("[data-card=\"term\"]");
        //debugger
        termEl.name = `Cards[${idx}].Term`;

        const defEl = containerEl.querySelector("[data-card=\"definition\"]");
        defEl.name = `Cards[${idx}].Definition`;
        idx++;
    }
}