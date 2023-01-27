@extends('app')

@section('title','Serivces')

@section('content')
  <h1>Welcome to Laravel 6 from Services</h1>

  <form action="/service" method="POST">
    <input type="text" name="name" autocomplete="off">
    @csrf
    <button>Add Service</button>
  </form>
  <p style="color: red;">@error('name') {{ $message }} @enderror</p>
  <ul>
    @forelse ($services as $service)
      <li>{{ $service->name }}</li>
    @empty
      <li>No Services Available</li>
    @endforelse
  </ul>
@endsection