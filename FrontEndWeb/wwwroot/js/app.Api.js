const ConsumeHttp = new HTTPClass;

const listData = document.querySelector("#listDataId");
const allCustomerBtn = document.querySelector("#allCustomerBtn");


allCustomerBtn.addEventListener("click", () => {
    // alert("Hey")
    ConsumeHttp.getAllCustomer("https://localhost:44395/api/account")
        .then(data => {
            let outputData = "";
            data.forEach(item => {
                outputData += `<a href="#" class="list-group-item list-group-item-action">
                                    <div class="d-flex w-100 justify-content-between">
                                        <h5 class="mb-1">${item.customer.name} ${item.customer.surname}</h5>
                                        <small>initialCredit ${item.customer.initialCredit}</small>
                                    </div>
                                    <p class="mb-1">Balance ${item.balance}</p>
                                    <small>Transaction ${item.transactions}</small>
                            </a>`
            });
            listData.innerHTML = outputData;

        })
        .catch(err => console.log(err));
});