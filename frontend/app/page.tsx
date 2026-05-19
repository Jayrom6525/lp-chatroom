// Main page of application
import Link from "next/link";

export default function Home() {
  return (
    <main>
      <h1>Welcome to the ChatRoom</h1>
      <p>click here to get started</p>
      <Link href="/Login">Login</Link>
    </main>
  );
}
