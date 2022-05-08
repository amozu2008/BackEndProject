class HTTPClass {

    async registerUsers(url, data) {
        const response = await fetch(url,
            {
                method: "POST",
                headers:
                {
                    "Content-type": "application/json"
                },
                body: JSON.stringify(data)
            });

        const responseData = await response.json();
        return responseData;
    }

    async getAllCustomer(url) {
        const reponse = await fetch(url);
        const responseData = await response.json();

        return responseData;
    }
}