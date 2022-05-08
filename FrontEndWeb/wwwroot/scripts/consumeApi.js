const ConsumeHttp = new HTTPClass;

const customerTxt = document.querySelector("#customerIdTxt");
const initialCreditTxt = document.querySelector("#initialCreditTxt");
const createBtn = document.querySelector("#btnid");
const alertBox = document.querySelector("#alertBoxId");
const listData = document.querySelector("#listDataId");
const allCustomerBtn = document.querySelector("#allCustomerBtn");


//createBtn.addEventListener("click", () => {
//    let customerValue = customerTxt.value;
//    let creditValue = initialCreditTxt.value;

//    if (customerValue == "" || creditValue == "") {

//        alertBox.innerHTML = `Please enter all fields`;
//        alertBox.classList.remove("alert-success");
//        alertBox.classList.add("alert-danger");
//        alertBox.classList.replace("d-none", "d-block");

//    }
//    else {
//        alertBox.classList.replace("d-block", "d-none");
//        const customerObj = {
//            customerId : customerValue,
//            initialCredit : creditValue
//        }
//        ConsumeHttp.registerUsers("https://localhost:44395/api/account", customerObj)
//            .then(data => {
//                                if (data.isSuccess) {

//                                    alertBox.innerHTML = data.displayMessages;
//                                    alertBox.classList.remove("alert-danger");
//                                    alertBox.classList.add("alert-success");
//                                    alertBox.classList.replace("d-none", "d-block");
//                                    customerValue == "";
//                                    creditValue == ""
//                                }
//                                else {
//                                    alertBox.innerHTML = data.displayMessages;
//                                    alertBox.classList.remove("alert-success");
//                                    alertBox.classList.add("alert-danger");
//                                    alertBox.classList.replace("d-none", "d-block");
//                                }
//                           })
//            .catch(err => console.log(err));
//    }

//});

allCustomerBtn.addEventListener("click", () => {
    alert("Hey")
    ConsumeHttp.getAllCustomer("https://localhost:44395/api/account")
        .then(data => {
            let outputData = "";
            data.forEach(post => {
                outputData += `<a href="#" class="list-group-item list-group-item-action">
                                    <div class="d-flex w-100 justify-content-between">
                                        <h5 class="mb-1">${data.customer.name} ${data.customer.surname}</h5>
                                        <small>initialCredit ${data.customer.initialCredit}</small>
                                    </div>
                                    <p class="mb-1">Balance ${data.balance}</p>
                                    <small>Transaction ${data.transactions}</small>
                            </a>`
            });
            listData.innerHTML = outputData;

        })
        .catch(err => console.log(err));
});