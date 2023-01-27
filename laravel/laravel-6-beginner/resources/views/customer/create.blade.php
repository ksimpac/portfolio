<h1>Add New Customer</h1>
<div>
    <a href="/customers">< back</a>
</div>
<form action="/customers" method="post">

    @include('customer.form')

    <input type="submit" value="Add New Customer">
</form>