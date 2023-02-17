import { Routes, Route } from 'react-router-dom'
import { Dashboard } from '../Pages/Dashboard'

function Router() {

    return (

        <Routes>
            <Route path="/" element={<Dashboard />}></Route>
        </Routes>

    )
}

export default Router