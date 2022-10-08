const sideMenu = document.querySelector("aside");
const menuBtn = document.querySelector("#menu-btn");
const closeBtn = document.querySelector("#close-btn");
const themeToggler = document.querySelector(".theme-toggler");

// open sidebar menu
menuBtn.addEventListener("click", () => {
    sideMenu.style.display = 'block';
});

// close sidebar menu
closeBtn.addEventListener("click", () => {
    sideMenu.style.display = 'none';
});




 const Orders = [
    {
        productName: 'Foldable Mini Drone',
        productNumber: '85631',
        paymentStatus: 'Due',
        shipping: 'Pending',
    },
    {
        productName: 'Larvender KF102 Drone',
        productNumber: '85246',
        paymentStatus: 'Refunded',
        shipping: 'Declined',
    },
    {
        productName: 'Ruko F11 Pro Drone',
        productNumber: '85245',
        paymentStatus: 'Due',
        shipping: 'Pending',
    },
    {
        productName: 'Drone with Camera Drone',
        productNumber: '85863',
        paymentStatus: 'Paid',
        shipping: 'Delivered',
    },
    {
        productName: 'GPS 4k Drone',
        productNumber: '82572',
        paymentStatus: 'Paid',
        shipping: 'Delivered',
    }
];

 Orders.forEach(order => {
    const tr = document.createElement('tr');
    const trContent = `
        <td>${order.productName}</td>
        <td>${order.productNumber}</td>
        <td>${order.paymentStatus}</td>
        <td class="${order.shipping === 'Declined' ? 'danger' : order.shipping === 'Pending' ? 'warning' : 'success'}">${order.shipping}</td>
        <td class="primary">Details</td>
    `;
    tr.innerHTML = trContent;
     document.querySelector('table .dashboard-table-body')?.appendChild(tr);
});