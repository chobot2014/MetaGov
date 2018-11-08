import * as React from 'react';
import { Link, NavLink } from 'react-router-dom';

export class NavMenu extends React.Component<{}, {}> {
    public render() {
        return <div className='main-nav-wrapper'>
            <ul className='main-nav'>
                <li>
                    <NavLink to={'/'} exact activeClassName='active'>
                        <span className='glyphicon glyphicon-home'></span> Home
                     </NavLink>
                </li>
                <li>
                </li>
                <li>
                    <NavLink to={'/vote'} activeClassName='active'>
                        <span className='glyphicon glyphicon-th-list'></span> Vote
                            </NavLink>
                </li>
            </ul>
        </div>;
    }
}
